﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public class DimensionFileContentGenerator : FileContentGenerator
    {
        protected override string GenerateFileContent(Column column)
        {
            var valueTypeName = column.Attributes.DestinationTypeName;
            var fileContent = new StringBuilder();
            if (IsUsingSystemRequired(valueTypeName))
            {
                fileContent.AppendLine("using System;");
                fileContent.AppendLine();
            }
            fileContent.AppendLine("namespace LinqAn.Google.Dimensions");
            fileContent.AppendLine("{");
            var className = column.ToClassName();
            var name = column.Attributes.UiName;
            var description = column.Attributes.Description;
            var escapedDescription = description.Replace("\"", "\\\"");
            var isAllowedInSegments = column.Attributes.IsAllowedInSegments.ToString().ToLowerInvariant();
            var id = column.Id;
            fileContent.AppendLine("\t/// <summary>");
            fileContent.AppendLine($"\t/// \t{description}");
            fileContent.AppendLine("\t/// </summary>");
            fileContent.AppendLine($"\tpublic class {className}: Dimension<{valueTypeName}>");
            fileContent.AppendLine("\t{");
            fileContent.AppendLine("\t\t/// <summary>");
            fileContent.AppendLine($"\t/// \tInstantiates a <seealso cref=\"{className}\" />.");
            fileContent.AppendLine("\t\t/// </summary>");
            fileContent.AppendLine($"\t\tpublic {className}(): base(\"{name}\",\"{escapedDescription}\",{isAllowedInSegments},\"{id}\")");
            fileContent.AppendLine("\t\t{");
            fileContent.AppendLine("\t\t\t");
            fileContent.AppendLine("\t\t}");
            fileContent.AppendLine("\t}");
            fileContent.AppendLine("}");
            return fileContent.ToString();
        }

        private static bool IsUsingSystemRequired(string typeName)
        {
            return typeName != "int" && typeName != "float" && typeName != "double" && typeName != "string" && typeName != "decimal";
        }
    }
}