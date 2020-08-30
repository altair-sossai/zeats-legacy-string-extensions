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

### string.SafeSubstring(int start, int length)
Ensures the realization of the substring without throwing exception
```c#
"12345 7890".SafeSubstring(start: 0, length: 9999) /* return "12345 7890" */
"12345 7890".SafeSubstring(start: 0, length: 1) /* return "1" */
"12345 7890".SafeSubstring(start: 0, length: 6) /* return "12345 " */
```
---
