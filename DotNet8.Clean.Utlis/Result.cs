using DotNet8.Clean.Utlis.Enums;

namespace DotNet8.Clean.Utlis;

public class Result<T>
{
	public T Data { get; set; }
	public string Message { get; set; }
	public bool IsSuccess {  get; set; }
	public EnumStatusCode StatusCode { get; set; }
}
