namespace ElegantLoops
{
	public ref struct IndexEnumerator
	{
		private int _current;
		private readonly int _end;
		public readonly int Current => _current;


		public IndexEnumerator(int count)
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
