namespace ElegantLoops
{
	public static class IndexLoop
	{
		public static IndexEnumerator GetEnumerator(this int count)
		{
			return new IndexEnumerator(count);
		}
	}
}
