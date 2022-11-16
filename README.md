# CLSS.ExtensionMethods.IEnumerable.ForEach

### Problem

[`ForEach`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.foreach) is a convenient method for `List<T>`. It provides a syntax similar to JavaScript's [`forEach`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/forEach) array method. However, by default, this method:

- Is not available to other `IEnumerable<T>` collections, even though by nature they can be iterated through a `foreach` loop.
- Returns void and therefore not very friendly to a functional-style call chain.
- Does not accept impure methods.
- Does not support passing through each element's index and the original collection like JavaScript's `forEach` array method.

### Solution

This package provides `ForEach` for all `IEnumerable<T>` collections to address all of the above issues.

Using `ForEach` with `HashSet`:

```csharp
using CLSS;

var uniqueIDs = new HashSet<int>() { 2, 4, 15, 22 };
uniqueIDs.ForEach(id => Console.WriteLine($"id: {id}"));
```
`ForEach` returns the source collection to continue to be used in a functional-style call chain:

```csharp
using CLSS;
using Newtonsoft.Json.Linq;
using System.Linq;

var itemNodes = JArray.Parse(rawJSON).Properties()
  .Select(p => p.Value)
  .Cast<JObject>()
  .ForEach(itemNode => UpdateItemLabel(itemNode))
  .ToList();
```

Using `ForEach` with impure methods:

```csharp
using CLSS;
using UnityEngine;

// In Unity's Scripting API, AssetBundle.LoadAssetAsync returns an
// AssetBundleRequest.
assetNames.ForEach(AssetBundle.LoadAssetAsync);
```

Using `ForEach` with JavaScript-style optional arguments:

```csharp
using CLSS;

(new float[] { 9.5f, 23.6f, 5.0f, 14.1f })
  .ForEach<float[], float>((n, i, srcNumbers) =>
  {
    float sumWithNeighbours = n;
    if (i > 0) sumWithNeighbours += srcNumbers[i - 1];
    if (i < srcNumbers.Length - 1) sumWithNeighbours += srcNumbers[i + 1];
    Console.WriteLine(sumWithNeighbours);
  });
```

The exact return type of `ForEach` will be determined by the invocation syntax. Below is how return type rules apply:

```csharp
using CLSS;

var numbers = new float[] { 0.0f, 1.0f, 2.0f };

// Implicit invocation and implicit lambda expression return IEnumerable<float>
numbers.ForEach(n => { }); // returns IEnumerable<float>
// Explicit invocation and implicit lambda expression return original type
numbers.ForEach<float[], float>(n => { }); // returns float[];
// Implicit invocation and explicit lambda expression return original type
numbers.ForEach((float n) => { }); // returns float[];
// Implicit invocation and delegate instance return original type
Action<float> ProcessNumber = n => { };
numbers.ForEach(ProcessNumber}); // returns float[];
// Implicit invocation and method reference return IEnumerable<float>
static void ProcessNumber(float n) { }
numbers.ForEach(ProcessNumber}); // returns IEnumerable<float>;
// Explicit invocation and method reference return original type
static void ProcessNumber(float n) { }
numbers.ForEach<float[], float>(ProcessNumber}); // returns float[];
```

Note that using lambdas in lieu of writing plain `foreach` loops will incur additional memory allocations. `ForEach` extension methods - just as with `List<T>.ForEach` - are meant to be syntactic sugar only. Only use it in performance-critical code paths if you can afford the added overhead.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).