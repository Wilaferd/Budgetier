using System;
using System.IO;
using GPT.MadMoney.Interfaces.Factories;

namespace GPT.MadMoney.Factories
{
    public class FileStreamFactory : IFileStreamFactory
    {
        public void ReadFileData()
        {
            using (var reader = File.OpenRead(""))
            {
                if (reader.CanRead)
                {
                    foreach (var line in File.ReadLines(""))
                    {
                        var y = line;
                    }
                    var x = reader.ReadAsync(new[] { new byte() }, Int32.MaxValue, 1);
                }
            }
        }
    }
}