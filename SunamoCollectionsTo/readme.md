### SunamoCollectionsTo

Provides helper methods for easier creation and conversion of collections between each other.

Part of PlatformIndependentNuGetPackages:

- [nuget.org](https://www.nuget.org/profiles/sunamo)
- [github.org](https://github.com/sunamo/PlatformIndependentNuGetPackages)

Other links:

- [Developer site](https://sunamo.cz)

Request for new features / bug report / etc: [Mail](mailto:radek.jancik@sunamo.cz) or on GitHub

## Key Methods

- `CollectionsHelperTo.ToList<T>(params T[])` - Converts an array of elements to a List.
- `CollectionsHelperTo.ToArray<T>(params T[])` - Returns the provided elements as an array.
- `CollectionsHelperTo.ToListString(params object[])` - Converts an array of objects to a List of strings.

## Target Frameworks

**TargetFrameworks:** `net10.0;net9.0;net8.0`

**Reason:** Code uses C# 12.0 features (collection expressions) requiring .NET 8.0+:
- Collection expressions `[]` syntax requires C# 12.0 (net8.0+)
