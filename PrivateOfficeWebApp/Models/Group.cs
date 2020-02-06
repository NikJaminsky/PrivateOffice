﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrivateOfficeWebApp.Models
{
	[JsonObject]
	public class Group
	{
		[JsonProperty("idGroup")]
		public int? IdGroup { get; set; }
		[JsonProperty("nameGroup")]
		public string NameGroup { get; set; }
		[JsonProperty("classes")]
		public virtual Classes? Classes { get; set; }
		[JsonProperty("student")]
		public virtual IList<Student>? Student { get; set; }
		[JsonProperty("course")]
		public virtual IList<Course>? Course { get; set; }

	}
}
