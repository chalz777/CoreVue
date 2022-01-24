 
namespace Web.Global.Mapper
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class AutoMapperDestination : Attribute
    {
        public Type TargetType { get; set; }
        public AutoMapperDestination(Type targetType)
        {
            TargetType = targetType;
        }
    }
}
