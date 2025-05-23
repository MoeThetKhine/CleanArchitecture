﻿namespace DotNet8.Clean.Shared;

#region DevCode

public static class DevCode
{
	public static string ToJson(this object obj) =>
		JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);

	public static T ToObject<T>(this string jsonStr) => JsonConvert.DeserializeObject<T>(jsonStr)!;

	public static bool IsNullOrEmpty(this string str) =>
		string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);

	public static IQueryable<TSource> Paginate<TSource>(this IQueryable<TSource> source, int pageNo, int pageSize)
	{
		return source.Skip((pageNo - 1) * pageSize).Take(pageSize);
	}
}

#endregion
