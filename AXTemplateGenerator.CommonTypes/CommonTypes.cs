using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AXTemplateGenerator.CommonTypes
{
    public class AXObjectType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    



    public class AOT
    {
        public List<AXTableType> tables;
    }

    public class AXTableType: AXObjectType
    {
        public List<AXFieldType> fields { get; set; }
    }

    public class AXFieldType: AXObjectType
    {
    }
}
