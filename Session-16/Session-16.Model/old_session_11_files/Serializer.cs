﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Session_16.Model.old_session_11_files
{
    public class Serializer
    {
        public void Serialize(object obj)
        {
            string jsonString = JsonSerializer.Serialize(obj);
        }
        public void SerializeToFile(object obj, string fileName)
        {

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(obj, options);

            File.WriteAllText(fileName, jsonString);
        }

        public T Deserialize<T>(string fileName)
        {

            string jsonString = File.ReadAllText(fileName);
            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;
        }
    }
}
