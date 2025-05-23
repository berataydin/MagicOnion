﻿// <auto-generated />
#pragma warning disable

namespace TempProject
{
    using global::System;
    using global::MessagePack;

    partial class MagicOnionInitializer
    {
        /// <summary>
        /// Gets the generated MessagePack formatter resolver.
        /// </summary>
        public static global::MessagePack.IFormatterResolver Resolver => MessagePackGeneratedResolver.Instance;
        class MessagePackGeneratedResolver : global::MessagePack.IFormatterResolver
        {
            public static readonly global::MessagePack.IFormatterResolver Instance = new MessagePackGeneratedResolver();

            MessagePackGeneratedResolver() {}

            public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
                => FormatterCache<T>.formatter;

            static class FormatterCache<T>
            {
                public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

                static FormatterCache()
                {
                    var f = MessagePackGeneratedGetFormatterHelper.GetFormatter(typeof(T));
                    if (f != null)
                    {
                        formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                    }
                }
            }
        }
        static class MessagePackGeneratedGetFormatterHelper
        {
            static readonly global::System.Collections.Generic.Dictionary<global::System.Type, int> lookup;

            static MessagePackGeneratedGetFormatterHelper()
            {
                lookup = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(23)
                {
                    {typeof(global::System.Collections.Generic.Dictionary<global::System.String, global::TempProject.MyResponse>), 0},
                    {typeof(global::System.Collections.Generic.HashSet<global::TempProject.MyResponse>), 1},
                    {typeof(global::System.Collections.Generic.ICollection<global::TempProject.MyResponse>), 2},
                    {typeof(global::System.Collections.Generic.IDictionary<global::System.String, global::TempProject.MyResponse>), 3},
                    {typeof(global::System.Collections.Generic.IEnumerable<global::TempProject.MyResponse>), 4},
                    {typeof(global::System.Collections.Generic.IList<global::TempProject.MyResponse>), 5},
                    {typeof(global::System.Collections.Generic.IReadOnlyCollection<global::TempProject.MyResponse>), 6},
                    {typeof(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::TempProject.MyResponse>), 7},
                    {typeof(global::System.Collections.Generic.IReadOnlyList<global::TempProject.MyResponse>), 8},
                    {typeof(global::System.Collections.Generic.IReadOnlySet<global::TempProject.MyResponse>), 9},
                    {typeof(global::System.Collections.Generic.ISet<global::TempProject.MyResponse>), 10},
                    {typeof(global::System.Collections.Generic.LinkedList<global::System.Int32>), 11},
                    {typeof(global::System.Collections.Generic.LinkedList<global::TempProject.MyResponse>), 12},
                    {typeof(global::System.Collections.Generic.List<global::System.Int32>), 13},
                    {typeof(global::System.Collections.Generic.List<global::TempProject.MyResponse>), 14},
                    {typeof(global::System.Collections.Generic.Queue<global::TempProject.MyResponse>), 15},
                    {typeof(global::System.Collections.Generic.SortedDictionary<global::System.String, global::TempProject.MyResponse>), 16},
                    {typeof(global::System.Collections.Generic.SortedList<global::System.Int32, global::TempProject.MyResponse>), 17},
                    {typeof(global::System.Collections.Generic.Stack<global::TempProject.MyResponse>), 18},
                    {typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<global::TempProject.MyResponse>), 19},
                    {typeof(global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::TempProject.MyResponse>), 20},
                    {typeof(global::System.Linq.IGrouping<global::System.Int32, global::TempProject.MyResponse>), 21},
                    {typeof(global::System.Linq.ILookup<global::System.Int32, global::TempProject.MyResponse>), 22},
                };
            }
            internal static object GetFormatter(global::System.Type t)
            {
                int key;
                if (!lookup.TryGetValue(t, out key))
                {
                    return null;
                }
            
                switch (key)
                {
                    case 0: return new global::MessagePack.Formatters.DictionaryFormatter<global::System.String, global::TempProject.MyResponse>();
                    case 1: return new global::MessagePack.Formatters.HashSetFormatter<global::TempProject.MyResponse>();
                    case 2: return new global::MessagePack.Formatters.InterfaceCollectionFormatter2<global::TempProject.MyResponse>();
                    case 3: return new global::MessagePack.Formatters.InterfaceDictionaryFormatter<global::System.String, global::TempProject.MyResponse>();
                    case 4: return new global::MessagePack.Formatters.InterfaceEnumerableFormatter<global::TempProject.MyResponse>();
                    case 5: return new global::MessagePack.Formatters.InterfaceListFormatter2<global::TempProject.MyResponse>();
                    case 6: return new global::MessagePack.Formatters.InterfaceReadOnlyCollectionFormatter<global::TempProject.MyResponse>();
                    case 7: return new global::MessagePack.Formatters.InterfaceReadOnlyDictionaryFormatter<global::System.String, global::TempProject.MyResponse>();
                    case 8: return new global::MessagePack.Formatters.InterfaceReadOnlyListFormatter<global::TempProject.MyResponse>();
                    case 9: return new global::MessagePack.Formatters.InterfaceReadOnlySetFormatter<global::TempProject.MyResponse>();
                    case 10: return new global::MessagePack.Formatters.InterfaceSetFormatter<global::TempProject.MyResponse>();
                    case 11: return new global::MessagePack.Formatters.LinkedListFormatter<global::System.Int32>();
                    case 12: return new global::MessagePack.Formatters.LinkedListFormatter<global::TempProject.MyResponse>();
                    case 13: return new global::MessagePack.Formatters.ListFormatter<global::System.Int32>();
                    case 14: return new global::MessagePack.Formatters.ListFormatter<global::TempProject.MyResponse>();
                    case 15: return new global::MessagePack.Formatters.QueueFormatter<global::TempProject.MyResponse>();
                    case 16: return new global::MessagePack.Formatters.SortedDictionaryFormatter<global::System.String, global::TempProject.MyResponse>();
                    case 17: return new global::MessagePack.Formatters.SortedListFormatter<global::System.Int32, global::TempProject.MyResponse>();
                    case 18: return new global::MessagePack.Formatters.StackFormatter<global::TempProject.MyResponse>();
                    case 19: return new global::MessagePack.Formatters.ReadOnlyCollectionFormatter<global::TempProject.MyResponse>();
                    case 20: return new global::MessagePack.Formatters.ReadOnlyDictionaryFormatter<global::System.String, global::TempProject.MyResponse>();
                    case 21: return new global::MessagePack.Formatters.InterfaceGroupingFormatter<global::System.Int32, global::TempProject.MyResponse>();
                    case 22: return new global::MessagePack.Formatters.InterfaceLookupFormatter<global::System.Int32, global::TempProject.MyResponse>();
                    default: return null;
                }
            }
        }
        /// <summary>Type hints for Ahead-of-Time compilation.</summary>
        [Preserve]
        static class TypeHints
        {
            [Preserve]
            internal static void Register()
            {
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::MessagePack.Nil>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.Dictionary<global::System.String, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.HashSet<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.ICollection<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.IDictionary<global::System.String, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.IEnumerable<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.IList<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.IReadOnlyCollection<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.IReadOnlyList<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.IReadOnlySet<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.ISet<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.LinkedList<global::System.Int32>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.LinkedList<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.List<global::System.Int32>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.List<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.Queue<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.SortedDictionary<global::System.String, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.SortedList<global::System.Int32, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.Generic.Stack<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.ObjectModel.ReadOnlyCollection<global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Int32>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Linq.IGrouping<global::System.Int32, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.Linq.ILookup<global::System.Int32, global::TempProject.MyResponse>>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::System.String>();
                _ = MessagePackGeneratedResolver.Instance.GetFormatter<global::TempProject.MyResponse>();
            }
        }
    }
}
