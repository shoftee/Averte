using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

using Maple.Net;
using Maple.Collections;

namespace Averte.Net
{
    public static class MapleHandler
    {
        private static Dictionary<ushort, MethodInfo> _handlers;

        public static bool Initialize()
        {
            _handlers = new Dictionary<ushort, MethodInfo>();

            foreach (var info in MapleHandler.FindMethodsByAttribute<PacketHandlerAttribute>())
            {
                PacketHandlerAttribute attribute = info.Left;
                MethodInfo method = info.Right;

                if (!_handlers.ContainsKey(attribute.Header))
                    _handlers.Add(attribute.Header, method);
            }

            return true;
        }

        public static MethodInfo GetHandler(ushort header)
        {
            MethodInfo meth;

            if (_handlers.TryGetValue(header, out meth))
                return meth;

            return null;
        }

        public static Action GetCallback(MethodInfo method, params object[] parameters)
        {
            return () => method.Invoke(null, parameters);
        }

        public static IEnumerable<Pair<TAttribute, MethodInfo>> FindMethodsByAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return (from method in AppDomain.CurrentDomain.GetAssemblies()
                        .Where(assembly => !assembly.GlobalAssemblyCache)
                        .SelectMany(assembly => assembly.GetTypes())
                        .SelectMany(type => type.GetMethods())
                    let attribute = Attribute.GetCustomAttribute(method, typeof(TAttribute), false) as TAttribute
                    where attribute != null
                    select new Pair<TAttribute, MethodInfo>(attribute, method));
        }
    }
}
