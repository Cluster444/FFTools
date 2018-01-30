using FlatBuffers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTools.Data
{
    public class DataManager
    {
        public StaticData Static { get; private set; }

        public DataManager(string staticDataName)
        {
            if (File.Exists(staticDataName))
            {
                var bytes = File.ReadAllBytes(staticDataName);
                var buffer = new ByteBuffer(bytes);
                Static = StaticData.GetRootAsStaticData(buffer);
            }
            else
            {
                throw new FileNotFoundException("Missing Static Data", staticDataName);
            }
        }
    }
}
