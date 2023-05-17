using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Social.Api.Filters
{
    public class XEnumNamesSchemaFilter : ISchemaFilter
    {
        // As we use enums, we would like to receive integers in request. We introduce x-enum-varnames with descriptions of our enum. So frontend people can autogenerate the code
        private const string NAME = "x-enum-varnames";

        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {
                var array = new OpenApiArray();
                array.AddRange(Enum.GetNames(context.Type).Select(n => new OpenApiString(n)));
                schema.Extensions.Add(NAME, array);
            }
        }
    }
}