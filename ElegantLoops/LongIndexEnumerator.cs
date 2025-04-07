namespace ElegantLoops
{
	public struct LongIndexEnumerator
	{
		private long _current;
		private readonly long _end;
		public readonly long Current => _current;


		public LongIndexEnumerator(long count)
		{
			_current = -1;
			_end = count;
		}


		public bool MoveNext()
		{
			++_current;
			return _current < _end;
		}
	}
}
