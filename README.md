![](/.github/banner.png?raw=true "")

# ℹ️ Features

* Various utility extensions for commonly used Unity and System types.
* Supports disabling extensions on a per-type basis: `EXT_0_<NAMESPACE>_<TYPE>`

<br/>


**⌛ Planned**

* [ ] Extensions for types defined outside Unity core module (Animation, UI, etc.) and preprocessor symbols to selectively enable them: `EXT_1_<NAMESPACE>_<TYPE>`
* [ ] Online documentation

<br/>

# 📦 Install

1. Open Package Manager
2. Paste GitHub URL:\
`https://github.com/Smidgens/unity-extensions.git#<version_tag>`


<br/>

# 🚀 Use

See `Runtime` folder for full list of extensions.

<br/>

#### ⭕ Disabling extensions for specific type



Add a preprocessor symbol to your project settings on the form: `EXT_0_<NAMESPACE>_<TYPE>`.

Example:

```cs
// disables extensions for System.Float
EXT_0_SYSTEM_FLOAT
```


