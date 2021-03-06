﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Xml;

namespace SchoolService
{
    /// <summary>
    /// Implements a Data Store with an XML file
    /// Serialization & Deserialization is generic
    /// LoadData and SaveData (XML) is specific to PersonList collection
    /// </summary>
	public static class DataStore
	{
		private const string FILENAME = "PersonData.xml";
		private static PersonList m_Data;

        /// <summary>
        /// DataStore Constructor
        /// Runs at the beginning of the singleton to
        /// clear the data store file
        /// </summary>
        static DataStore()
        {
            ClearData();
        }

        /// <summary>
        /// ClearData
        /// Removes the temporary file used as a 
        /// data store for this application so that
        /// fresh data can be considered for testing
        /// </summary>
        public static void ClearData()
        {
            string path = Path.Combine(Path.GetTempPath(), FILENAME);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        /// <summary>
        /// Serializes an object of type T to a string using the DataContractSerializer
        /// </summary>
        /// <typeparam name="T">Type of object to serialize</typeparam>
        /// <param name="obj">Object to serialize</param>
        /// <returns>Serialized object as a string</returns>
        public static string Serialize<T>(T obj)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
				serializer.WriteObject(memoryStream, obj);
				return Encoding.UTF8.GetString(memoryStream.ToArray());
			}
		} // end of method

		/// <summary>
		/// Deserializes the given xml string into an object of type T
		/// </summary>
		/// <typeparam name="T">Type of object to deserialize</typeparam>
		/// <param name="xml">Data to deserialize</param>
		/// <returns>Reconstituted object</returns>
		public static T Deserialize<T>(string xml)
		{
			using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
			{
				Type toType = typeof(T);
				XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(memoryStream, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
				DataContractSerializer serializer = new DataContractSerializer(toType);
				return (T)serializer.ReadObject(reader);
			}
		} // end of method

		/// <summary>
		/// Loads the PersonList from a file
		/// </summary>
		/// <returns>PersonList data</returns>
		public static PersonList LoadData()
		{
			string path = Path.Combine(Path.GetTempPath(), FILENAME);
			if (m_Data == null && File.Exists(path))
			{
				string ser = File.ReadAllText(path);
				m_Data = Deserialize<PersonList>(ser);
			}
			if (m_Data == null)
			{
				m_Data = new PersonList();
			}
			return m_Data;
		} // end of method

		/// <summary>
		/// Saves the PersonList data
		/// </summary>
		public static void SaveData()
		{
			string path = Path.Combine(Path.GetTempPath(), FILENAME);
			if (m_Data == null)
			{
				m_Data = new PersonList();
			}
			string ser = Serialize(m_Data);
			File.WriteAllText(path, ser);
		} // end of method

	} // end of class
} // end of namespace