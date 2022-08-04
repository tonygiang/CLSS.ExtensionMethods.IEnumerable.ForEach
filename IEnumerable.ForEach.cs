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

    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"/>
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
    /// <typeparam name="T">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='T']"/></typeparam>
    /// <typeparam name="TElement">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='TElement']"/></typeparam>
    /// <typeparam name="TResult">The return type of the <paramref name="func"/>
    /// delegate.</typeparam>
    /// <param name="source">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/param[@name='source']"/></param>
    /// <param name="func">The <see cref="Func{T, TResult}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>.</param>
    /// <returns><inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/returns"/></returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or
    /// <paramref name="func"/> is null.</exception>
    public static T ForEach<T, TElement, TResult>(this T source,
      Func<TElement, TResult> func)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      foreach (var e in source) func(e);
      return source;
    }

    /// <inheritdoc cref="ForEach{T, TElement, TResult}(T, Func{TElement, TResult})"/>
    public static IEnumerable<TElement> ForEach<TElement, TResult>(
      this IEnumerable<TElement> source,
      Func<TElement, TResult> func)
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
    /// <typeparam name="T">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='T']"/></typeparam>
    /// <typeparam name="TElement">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='TElement']"/></typeparam>
    /// <param name="source">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/param[@name='source']"/></param>
    /// <param name="action">The <see cref="Action{T1, T2}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index.</param>
    /// <returns><inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/returns"/></returns>
    /// <exception cref="ArgumentNullException">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/exception[@cref='ArgumentNullException']"/></exception>
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

    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement, int})"/>
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
    /// <typeparam name="T">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='T']"/></typeparam>
    /// <typeparam name="TElement">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='TElement']"/></typeparam>
    /// <typeparam name="TResult">
    /// <inheritdoc cref="ForEach{T, TElement, TResult}(T, Func{TElement, TResult})"
    /// path="/typeparam[@name='TResult']"/></typeparam>
    /// <param name="source">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/param[@name='source']"/></param>
    /// <param name="func">The <see cref="Func{T1, T2, TResult}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index.</param>
    /// <returns><inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/returns"/></returns>
    /// <exception cref="ArgumentNullException">
    /// <inheritdoc cref="ForEach{T, TElement, TResult}(T, Func{TElement, TResult})"
    /// path="/exception[@cref='ArgumentNullException']"/></exception>
    public static T ForEach<T, TElement, TResult>(this T source,
      Func<TElement, int, TResult> func)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      int index = 0;
      foreach (var e in source) { func(e, index); ++index; }
      return source;
    }

    /// <inheritdoc cref="ForEach{T, TElement, TResult}(T, Func{TElement, int, TResult})"/>
    public static IEnumerable<TElement> ForEach<TElement, TResult>(
      this IEnumerable<TElement> source,
      Func<TElement, int, TResult> func)
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
    /// <typeparam name="T">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='T']"/></typeparam>
    /// <typeparam name="TElement">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='TElement']"/></typeparam>
    /// <param name="source">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/param[@name='source']"/></param>
    /// <param name="action">The <see cref="Action{T1, T2, T3}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index and the third argument being
    /// <paramref name="source"/>.</param>
    /// <returns><inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/returns"/></returns>
    /// <exception cref="ArgumentNullException">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/exception[@cref='ArgumentNullException']"/></exception>
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

    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement, int, T})"/>
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
    /// <typeparam name="T">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='T']"/></typeparam>
    /// <typeparam name="TElement">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/typeparam[@name='TElement']"/></typeparam>
    /// <typeparam name="TResult">
    /// <inheritdoc cref="ForEach{T, TElement, TResult}(T, Func{TElement, TResult})"
    /// path="/typeparam[@name='TResult']"/></typeparam>
    /// <param name="source">
    /// <inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/param[@name='source']"/></param>
    /// <param name="func">The <see cref="Func{T1, T2, T3, T4}"/> delegate to
    /// perform on each element of the <see cref="IEnumerable{T}"/>, with its
    /// second argument being the element's index and the third argument being
    /// <paramref name="source"/>.</param>
    /// <returns><inheritdoc cref="ForEach{T, TElement}(T, Action{TElement})"
    /// path="/returns"/></returns>
    /// <exception cref="ArgumentNullException">
    /// <inheritdoc cref="ForEach{T, TElement, TResult}(T, Func{TElement, TResult})"
    /// path="/exception[@cref='ArgumentNullException']"/></exception>
    public static T ForEach<T, TElement, TResult>(this T source,
      Func<TElement, int, T, TResult> func)
      where T : IEnumerable<TElement>
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      int index = 0;
      foreach (var e in source) { func(e, index, source); ++index; }
      return source;
    }

    /// <inheritdoc cref="ForEach{T, TElement, TResult}(T, Func{TElement, int, T, TResult})"/>
    public static IEnumerable<TElement> ForEach<T, TElement, TResult>(
      this IEnumerable<TElement> source,
      Func<TElement, int, IEnumerable<TElement>, TResult> func)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (func == null) throw new ArgumentNullException("func");
      int index = 0;
      foreach (var e in source) { func(e, index, source); ++index; }
      return source;
    }
  }
}
