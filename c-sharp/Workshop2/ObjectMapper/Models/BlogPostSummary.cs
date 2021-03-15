using System;

namespace ObjectMapper.Models
{
	public class BlogPostSummary
	{
		public int Id { get; set; }
		public string BlogUrl { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string CoverImage { get; set; }
		public DateTime PublishedAt { get; set; }
	}
}
