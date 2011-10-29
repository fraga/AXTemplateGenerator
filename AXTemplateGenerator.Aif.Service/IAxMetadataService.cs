using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AXTemplateGenerator.Aif.Service
{
    public interface IAxMetadataService: IServiceProvider
    {
        string[] GetTableNames();
        string[] GetClassNames();
        string[] GetExtendedDataTypeNames();
        string[] GetEnumNames();
        string[] GetQueryNames();
        string[] GetServiceNames();
        string[] GetFormPartNames();
    }
}
