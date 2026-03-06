# Ordering (sorting)
These operators allow us to sort the output of a sequence.

The operators used for ordering are:

- `orderby` - Orders elements ascending by default, multiple inputs can be used separated by comma, ordering by `first`, then `second` input.
    - `descending` - Add this keyword for descending order
    - `ascending` - Add this keyword for ascending order

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/sorting-data)

- [x] - Implemented

# Filtering (condition)
The operator `where` allows us to set a specific condition for a sequence, returning elements thta satisfy the condition as `true`.

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/filtering-data)

- [x] - Implemented

# Partitioning (slicing)
The operators `take`, `skip`, `takeWhile` and `skipWhile` allow us to "slice" parts of a sequence.

`takeWhile` and `skipWhile` take a predicate that will return only elements that fit a specific condition.

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/partitioning-data)

- [x] - Implemented

# Aggregating (single value)
The operators `Count` , `Min`, `Max`, `Average` and `Sum` perform calculations on a sequence.

- [x] - Implemented

# Projection (transformation)
The operators `select` and `selectMany` allow us to "map" each item into a new form.

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/projection-operations)

- [x] - Implemented

# Grouping
The operators `GroupBy` and `into` groups data into buckets of which elements share a common key.

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/grouping-data)

- [ ] - Implemented

# Quantifiers
The operators `Any`, `Contains` and `All`  return a `boolean` based on the condition predicate.

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/quantifier-operations)

- [x] - Implemented

# Elements
The operators `Single`, `SingleOrDefault`,`First`, `FirstOrDefault`,`Last`, `LastOrDefault` and `ElementAt` retrieve elements based on their position.

`FirstOrDefault` and `LastOrDefault` returns the default value of the type if no match, the other throw an exception.
    - `null` for reference types
    - `0` for int
    - `false` for bools 

- [x] - Implemented

# Conversion
The operators `ToList`, `ToArray`, `Cast` converts the result to a specific type.

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/converting-data-types)

- [x] - Implemented (mostly `ToList`)

# Set
The operators `Distinct`, `Except`, `Intersect` and `Union` produce a result based on the `absence` or `presence` of items between two collection.

- `Distinct` - Returns unique elements (removes duplicates)
    - `DisctinctBy` - Same as `distinct`, but we can pass it a predicate from which unique items based on a condition are returned, for example, `DistinctBy(n => n.Length)` - Only the first item of two items with the same length will be returned.
- `Except` - Returns only the items from one collection that dont appear in the other collection.
    - `ExceptBy` - Works the same as `Except` but we can pass it a predicate that specifies what value we want to use.
- `Intersect` - Returns elements that appear in both collections.
- `Union` - Returns elements that are by unique in both collections.

[Resource link](https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/set-operations)

- [ ] - Implemented

# Join
...
# Generators
...