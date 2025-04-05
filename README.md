# ElegantLoop

Sometimes, even the simplest things deserve elegance. And this loop is exactly that!
You can turn this 💩:
```csharp
for (int i = 0; i < count; i++)
{
	// Your code inside this overly verbose loop 😡
}
```
into this 🎂:
```csharp
foreach (int i in count)
{
	// Your code inside a minimalistic, elegant loop ✨
	// So beautiful it makes your linter weep with joy 😌
}
```

No more months of debugging because you wrote <= instead of <!
No more pondering “is it i++ or ++i this time?”!
Just pure, readable iteration.

> Uncle Bob might have said:
> “Every code with loops like this is clean! And every other is not.”
> — If you disagree, well... I hope your free e-book came with a refund policy. 😉

## Benchmarks?
Yes, we did those too.
The ElegantLoop holds its ground against the classic for loop, and even wins in many cases.
Check the Benchmark project if you’re into raw numbers and bragging rights.

## Tests?
Of course!
This loop is bulletproof. We’ve tested zero, negative, and mega-huge counts — and it still behaves like a champ.
See the tests folder and judge for yourself.

## Why?
Because we could.
Because it’s funny.
And maybe, just maybe… because writing foreach (int i in count) feels good. 😌

## Conclusion
You might think you don't need this.
But trust me — once you try it, there’s no going back.
And guess what? It’s free! …for now 😈

## License
This project is licensed under the MIT License —
use it freely, copy it shamelessly, but hey — drop a ⭐ if it made you smile.