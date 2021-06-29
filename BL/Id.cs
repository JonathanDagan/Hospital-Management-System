using System;

namespace BL
{
    public class Id
    {
        public string id { get; set; }
        // TODO: limit to only actual ids
        public Id(string id)
        {
            this.id = id;
        }
    }
}
