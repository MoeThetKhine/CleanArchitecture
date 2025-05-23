﻿namespace DotNet8.Clean.DTO.Features.PageSetting;

#region PageSettingModel

public class PageSettingModel
{
	public int PageNo {  get; set; }
	public int PageSize {  get; set; }
	public int PageCount { get; set; }
	public int TotalCount {  get; set; }

	public PageSettingModel(int pageNo, int pageSize, int pageCount, int totalCount)
	{
		PageNo = pageNo;
		PageSize = pageSize;
		PageCount = pageCount;
		TotalCount = totalCount;
	}	
}

#endregion