namespace ElegantLoops
{
	public static class IndexLoop
	{
		public static IndexEnumerator GetEnumerator(this int count)
		{
			return new IndexEnumerator(count);
		}


		public static LongIndexEnumerator GetEnumerator(this long count)
		{
			return new LongIndexEnumerator(count);
		}
	}
}
