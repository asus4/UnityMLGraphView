using System;
using System.IO;
using FlatBuffers;

namespace MLGraph
{

    public class ModelReader : System.IDisposable
    {
        public ModelReader(string path)
        {
            var bytes = File.ReadAllBytes(path);

        }

        public void Dispose()
        {

        }
    }
}