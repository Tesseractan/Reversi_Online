using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using static System.Convert;

namespace Reversi_Online
{
    static class Extensions
    {
        public static T GetFirstMaxProperty<T>(this ICollection<T> collection, params string[] properties_names_stroke)
        {
            return (collection.GetMaxProperties(properties_names_stroke) as List<T>)[0];
        }
        public static T GetLastMaxProperty<T>(this ICollection<T> collection, params string[] properties_names_stroke)
        {
            ICollection<T> all_maxes = collection.GetMaxProperties(properties_names_stroke);
            return (all_maxes as List<T>)[all_maxes.Count - 1];
        }
        public static ICollection<T> GetMaxProperties<T>(this ICollection<T> collection, params string[] properties_names_stroke)
        {
            ICollection<T> maxes = new List<T>();
            PropertyInfo property_info = null;
            bool initialized = false;
            string[] cut_stroke = properties_names_stroke.Take(properties_names_stroke.Length - 1).ToArray();
            foreach (T candidate in collection)
            {
                if (initialized)
                {
                    object candidate_property_parent = candidate.GetType().GetStrokePropertyValue(candidate, cut_stroke);
                    object candidate_property_value = property_info.GetValue(candidate_property_parent);
                    if (!(candidate_property_value is IFormattable)) throw new ArgumentException();
                    ICollection<T> sames = new List<T>();
                    bool accepting_candidate = true;
                    foreach (T max in maxes)
                    {
                        object max_property_parent = max.GetType().GetStrokePropertyValue(max, cut_stroke);
                        object max_property_value = property_info.GetValue(max_property_parent);
                        if (ToDouble(candidate_property_value) < ToDouble(max_property_value))
                        {
                            accepting_candidate = false;
                            break;
                        }
                        else if (ToDouble(candidate_property_value) == ToDouble(max_property_value))
                        {
                            sames.Add(max);
                        }
                    }
                    if (accepting_candidate)
                    {
                        maxes.Clear();
                        maxes.AddRange(sames);
                        maxes.Add(candidate);

                    }

                }
                else
                {
                    Type type = candidate.GetType();
                    property_info = type.GetStrokeProperty(properties_names_stroke);
                    maxes.Add(candidate);
                    initialized = true;
                }

            }
            return maxes;
        }
        public static T GetFirstMinProperty<T>(this ICollection<T> collection, params string[] properties_names_stroke)
        {
            return (collection.GetMinProperties(properties_names_stroke) as List<T>)[0];
        }
        public static T GetLastMinProperty<T>(this ICollection<T> collection, params string[] properties_names_stroke)
        {
            ICollection<T> all_maxes = collection.GetMinProperties(properties_names_stroke);
            return (all_maxes as List<T>)[all_maxes.Count - 1];
        }
        public static ICollection<T> GetMinProperties<T>(this ICollection<T> collection, params string[] properties_names_stroke)
        {
            ICollection<T> mines = new List<T>();
            PropertyInfo property_info = null;
            bool initialized = false;
            string[] cut_stroke = properties_names_stroke.Take(properties_names_stroke.Length - 1).ToArray();
            foreach (T candidate in collection)
            {
                if (initialized)
                {
                    object candidate_property_parent = candidate.GetType().GetStrokePropertyValue(candidate, cut_stroke);
                    object candidate_property_value = property_info.GetValue(candidate_property_parent);
                    if (!(candidate_property_value is IFormattable)) throw new ArgumentException();
                    ICollection<T> sames = new List<T>();
                    bool accepting_candidate = true;
                    foreach (T max in mines)
                    {
                        object max_property_parent = max.GetType().GetStrokePropertyValue(max, cut_stroke);
                        object max_property_value = property_info.GetValue(max_property_parent);
                        if (ToDouble(candidate_property_value) > ToDouble(max_property_value))
                        {
                            accepting_candidate = false;
                            break;
                        }
                        else if (ToDouble(candidate_property_value) == ToDouble(max_property_value))
                        {
                            sames.Add(max);
                        }
                    }
                    if (accepting_candidate)
                    {
                        mines.Clear();
                        mines.AddRange(sames);
                        mines.Add(candidate);

                    }

                }
                else
                {
                    Type type = candidate.GetType();
                    property_info = type.GetStrokeProperty(properties_names_stroke);
                    mines.Add(candidate);
                    initialized = true;
                }

            }
            return mines;
        }
        public static PropertyInfo GetStrokeProperty(this Type type, params string[] properties_names_stroke)
        {
            PropertyInfo output = null;
            for (int i = 0; i < properties_names_stroke.Length; i++)
            {
                output = type.GetProperty(properties_names_stroke[i]);
                type = output.GetMethod.ReturnType;
            }
            return output;
        }
        public static object GetStrokePropertyValue(this Type type, object obj, params string[] properties_names_stroke)
        {

            object output = obj;

            for (int i = 0; i < properties_names_stroke.Length; i++)
            {
                output = type.GetProperty(properties_names_stroke[i]).GetValue(obj);
                obj = output;
                type = output.GetType();
            }
            return output;
        }
        public static void AddRange<T>(this ICollection<T> collection, ICollection<T> second_collection)
        {
            foreach (T item in second_collection)
            {
                collection.Add(item);
            }
        }

        public static void Transfer(this int i, int amount, ref int receiver)
        {
            i -= amount;
            receiver += amount;
        }
    }
}
