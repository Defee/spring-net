namespace System
{
#if NETCORE
    internal static class TypeExtensions
    {
        public static Reflection.TypeInfo GetType(this object obj)
        {
            return System.Reflection.IntrospectionExtensions.GetTypeInfo(obj.GetType());
        }
    }
#endif


#if !BINARY_SERIALIZATION
    public class SerializableAttribute : Attribute
    {
    }

    public class NonSerializedAttribute : Attribute
    {
    }
#endif

#if NETCORE
    public class ApplicationException : Exception
    {
        public ApplicationException()
        {
        }

        public ApplicationException(string message) : base(message)
        {
        }

        public ApplicationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public interface ICloneable
    {
        object Clone();
    }

    internal interface ISerializable
    {
    }

    internal interface IDeserializationCallback
    {
    }

    namespace Configuration.Internal
    {
        public interface IConfigErrorInfo
        {
        }
    }
#endif
}