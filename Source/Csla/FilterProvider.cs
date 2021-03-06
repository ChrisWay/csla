//-----------------------------------------------------------------------
// <copyright file="FilterProvider.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Defines the method signature for a filter</summary>
//-----------------------------------------------------------------------
using System;

namespace Csla
{
  /// <summary>
  /// Defines the method signature for a filter
  /// provider method used by FilteredBindingList.
  /// </summary>
  /// <param name="item">The object to be filtered.</param>
  /// <param name="filter">The filter criteria.</param>
  /// <returns><see langword="true"/> if the item matches the filter.</returns>
  public delegate bool FilterProvider(object item, object filter);
}