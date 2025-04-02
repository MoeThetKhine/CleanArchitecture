using DotNet8.Clean.Utlis.Enums;

namespace DotNet8.Clean.Utlis;

public class Result<T>
{
	public T Data { get; set; }
	public string Message { get; set; }
	public bool IsSuccess {  get; set; }
	public EnumStatusCode StatusCode { get; set; }

	#region Success

	public static Result<T> Success(string message = "Success", EnumStatusCode statusCode = EnumStatusCode.Success)
	{
		return new Result<T>
		{
			IsSuccess = true,
			Message = message,
			StatusCode = statusCode
		};
	}

	#endregion

	#region Success

	public static Result<T> Success(T data, string message = "Success.", EnumStatusCode statusCode = EnumStatusCode.Success)
	{
		return new Result<T>
		{
			Data = data,
			IsSuccess = true,
			Message = message,
			StatusCode = statusCode
		};
	}

	#endregion

	#region SaveSuccess

	public static Result<T> SaveSuccess(string message = "Saving Successful.", EnumStatusCode statusCode = EnumStatusCode.Success)
	{
		return new Result<T>
		{
			IsSuccess = true,
			Message = message,
			StatusCode = statusCode
		};
	}

	#endregion

	#region UpdateSuccess

	public static Result<T> UpdateSuccess(string message = "Update Successful.", EnumStatusCode statusCode = EnumStatusCode.Success)
	{
		return new Result<T>
		{
			IsSuccess = true,
			Message = message,
			StatusCode = statusCode
		};
	}

	#endregion

	public static Result<T> DeleteSuccess(string message = "Delete Successful.", EnumStatusCode statusCode = EnumStatusCode.Success)
	{
		return new Result<T>
		{
			IsSuccess = true,
			Message = message,
			StatusCode = statusCode
		};
	}

	public static Result<T> Fail(string message = "Failed.", EnumStatusCode statusCode = EnumStatusCode.BadRequest)
	{
		return new Result<T>
		{
			IsSuccess = false,
			Message = message,
			StatusCode = statusCode
		};
	}

	public static Result<T> Failure(Exception ex)
	{
		return new Result<T>
		{
			IsSuccess = false,
			Message = ex.Message,
			StatusCode = EnumStatusCode.InternalServerError
		};
	}

	public static Result<T> NotFound(string message = "No Data Found.", EnumStatusCode statusCode = EnumStatusCode.NotFound)
	{
		return new Result<T>
		{
			IsSuccess = false,
			Message = message,
			StatusCode = statusCode
		};
	}

}
