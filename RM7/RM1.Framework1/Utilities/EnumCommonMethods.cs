using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace RM1.Framework1.Utilities
{
    public static class EnumCommonMethods
    {
        /// <summary>
        /// 获取枚举值的描述信息
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <returns>描述信息</returns>
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            var field = type.GetField(value.ToString());
            if (field.IsDefined(typeof(DescriptionAttribute), true))
            {
                DescriptionAttribute description = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute), true);
                return description.Description;
            }
            else
            {
                return value.ToString();
            }
        }

        /// <summary>
        /// 根据枚举描述信息获取第一个匹配的枚举值
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="description">描述信息</param>
        /// <returns></returns>
        public static T GetEnumValue<T>(string description) where T:Enum
        {
            IEnumerable<T> enumValues = Enum.GetValues(typeof(T)).OfType<T>();
            return enumValues.FirstOrDefault(value => EnumCommonMethods.GetDescription(value) == description);
        }
    }
}
