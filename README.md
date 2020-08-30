# zeats-legacy-string-extensions

Extensions to solve common problems when using strings

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-string-extensions?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=17&branchName=master)

## Installation

```PM>
Install-Package Zeats.Legacy.StringExtensions
```

## Extensions

### string.FirstCharToUpper()

Upercase the first position of the string

```c#
"lorem ipsum dolor".FirstCharToUpper() /* return "Lorem ipsum dolor" */
"lOREM IPSUM DOLOR".FirstCharToUpper() /* return "LOREM IPSUM DOLOR" */
"LOREM IPSUM DOLOR".FirstCharToUpper() /* return "LOREM IPSUM DOLOR" */
```

---
