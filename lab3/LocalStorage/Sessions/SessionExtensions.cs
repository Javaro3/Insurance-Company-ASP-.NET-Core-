using Newtonsoft.Json;

namespace lab3.LocalStorage.Sessions
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            var entity = value == null ? default : JsonConvert.DeserializeObject<T>(value);
            return entity;
        }
    }
}