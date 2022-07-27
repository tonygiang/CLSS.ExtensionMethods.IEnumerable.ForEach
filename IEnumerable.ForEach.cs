// A part of the C# Language Syntactic Sugar suite.

using System;
using System.Collections.Generic;

namespace CLSS
{
  public static partial class IEnumerableForEach
  {
    /// <summary>
    /// Performs the specified action on each element of the
    /// <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to iterate
    /// action on.</typeparam>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="action">The <see cref="Action{T}"/> delegate to perform on
    /// each element of the <see cref="IEnumerable{T}"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="action"/> is null.</exception>
    public static T ForEach<T, TElement>(this T source,
      Action<TElement> action)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (action == null) throw new ArgumentNullException("action");
      foreach (var e in source) action(e);
      return source;
    }

    /// <summary>
    /// Performs the specified action on each element of the
    /// <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="action">The <see cref="Action{T}"/> delegate to perform on
    /// each element of the <see cref="IEnumerable{T}"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="action"/> is null.</exception>
    public static IEnumerable<TElement> ForEach<TElement>(
      this IEnumerable<TElement> source,
      Action<TElement> action)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (action == null) throw new ArgumentNullException("action");
      foreach (var e in source) action(e);
      return source;
    }

    /// <summary>
    /// Performs the specified function on each element of the
    /// <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to iterate
    /// function on.</typeparam>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="func">The <see cref="Func{T}"/> delegate to perform on
    /// each element of the <see cref="IEnumerable{T}"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="func"/> is null.</exception>
    public static T ForEach<T, TElement, TR>(this T source,
      Func<TElement, TR> func)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      foreach (var e in source) func(e);
      return source;
    }

    /// <summary>
    /// Performs the specified function on each element of the
    /// <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="func">The <see cref="Func{T}"/> delegate to perform on
    /// each element of the <see cref="IEnumerable{T}"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="func"/> is null.</exception>
    public static IEnumerable<TElement> ForEach<TElement, TR>(
      this IEnumerable<TElement> source,
      Func<TElement, TR> func)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      foreach (var e in source) func(e);
      return source;
    }

    /// <summary>
    /// Performs the specified action on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to iterate
    /// action on.</typeparam>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="action">The <see cref="Action{T1, T2}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="action"/> is null.</exception>
    public static T ForEach<T, TElement>(this T source,
      Action<TElement, int> action)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (action == null) throw new ArgumentNullException("action");
      int index = 0;
      foreach (var e in source) { action(e, index); ++index; }
      return source;
    }

    /// <summary>
    /// Performs the specified action on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index.
    /// </summary>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="action">The <see cref="Action{T1, T2}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="action"/> is null.</exception>
    public static IEnumerable<TElement> ForEach<TElement>(
      this IEnumerable<TElement> source,
      Action<TElement, int> action)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (action == null) throw new ArgumentNullException("action");
      int index = 0;
      foreach (var e in source) { action(e, index); ++index; }
      return source;
    }

    /// <summary>
    /// Performs the specified function on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to iterate
    /// action on.</typeparam>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="func">The <see cref="Func{T1, T2}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="func"/> is null.</exception>
    public static T ForEach<T, TElement, TR>(this T source,
      Func<TElement, int, TR> func)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      int index = 0;
      foreach (var e in source) { func(e, index); ++index; }
      return source;
    }

    /// <summary>
    /// Performs the specified function on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index.
    /// </summary>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="func">The <see cref="Func{T1, T2}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="func"/> is null.</exception>
    public static IEnumerable<TElement> ForEach<TElement, TR>(
      this IEnumerable<TElement> source,
      Func<TElement, int, TR> func)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      int index = 0;
      foreach (var e in source) { func(e, index); ++index; }
      return source;
    }

    /// <summary>
    /// Performs the specified action on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index and
    /// the collection being iterated on.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to iterate
    /// action on.</typeparam>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="action">The <see cref="Action{T1, T2, T3}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index and the third argument being
    /// <paramref name="source"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="action"/> is null.</exception>
    public static T ForEach<T, TElement>(this T source,
      Action<TElement, int, T> action)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (action == null) throw new ArgumentNullException("action");
      int index = 0;
      foreach (var e in source) { action(e, index, source); ++index; }
      return source;
    }

    /// <summary>
    /// Performs the specified action on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index and
    /// the collection being iterated on.
    /// </summary>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="action">The <see cref="Action{T1, T2, T3}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index and the third argument being
    /// <paramref name="source"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="action"/> is null.</exception>
    public static IEnumerable<TElement> ForEach<TElement>(
      this IEnumerable<TElement> source,
      Action<TElement, int, IEnumerable<TElement>> action)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (action == null) throw new ArgumentNullException("action");
      int index = 0;
      foreach (var e in source) { action(e, index, source); ++index; }
      return source;
    }

    /// <summary>
    /// Performs the specified function on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index and
    /// the collection being iterated on.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IEnumerable{T}"/> to iterate
    /// action on.</typeparam>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="func">The <see cref="Func{T1, T2, T3}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index and the third argument being
    /// <paramref name="source"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="func"/> is null.</exception>
    public static T ForEach<T, TElement, TR>(this T source,
      Func<TElement, int, T, TR> func)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      int index = 0;
      foreach (var e in source) { func(e, index, source); ++index; }
      return source;
    }

    /// <summary>
    /// Performs the specified function on each element of the
    /// <see cref="IEnumerable{T}"/>, passing through the element's index and
    /// the collection being iterated on.
    /// </summary>
    /// <typeparam name="TElement">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to iterate action
    /// on.</param>
    /// <param name="func">The <see cref="Func{T1, T2, T3}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index and the third argument being
    /// <paramref name="source"/>.</param>
    /// <returns>The source collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="func"/> is null.</exception>
    public static IEnumerable<TElement> ForEach<T, TElement, TR>(
      this IEnumerable<TElement> source,
      Func<TElement, int, IEnumerable<TElement>, TR> func)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      int index = 0;
      foreach (var e in source) { func(e, index, source); ++index; }
      return source;
    }
  }
}
