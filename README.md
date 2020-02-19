# dotnet-tab

A simple tab class for use with building formatted documents in .NET

## How to use

### Tab.Get

Returns a tab of the set size or default size if no size was set. `Tab.Get()` takes an optional tab count, which will repeat the tab by the count number.

> `Tab.Get()`
>
> By default, this returns a blank string of length 4.

> `Tab.Get(2)`
>
> Providing an integer to `Tab.Get()` repeats the tab. The call above returns a blank string of length 8, or two length 4 tabs.

> `Tab.Get(0)`
>
> Passing zero to `Tab.Get()` produces no tabs - a string of length zero.

### Tab.SetSize

Sets the size of the tabs returned by subsequent calls to `Tab.Get()`.

> `Tab.SetSize(2)`
>
> `Tab.Get()`
>
> After setting the size to 2, the result of the calls above is a blank string of length 2.

### Tab.ResetDefaultSize

Resets the tab's size to the default size of 4.

> `Tab.SetSize(2)`
>
> `Tab.ResetDefaultSize()`
>
> `Tab.Get()`
>
> Even though the tab size has been set to 2 above, calling `Tab.ResetDefaultSize()` resets the tab's size to 4, to the result of the call to `Tab.Get()` above will be a blank string of length 4.

## Special considerations

Tab is a very simple static class, which is essentially a wrapper for a static variable that holds a tab value. It is assumed that the tab size won't change
more than once during the execution of any program in which it's used, but if your use requires that it changes, special care should be taken to accomodate the static nature of the state, considering things like thread-safety.

If you need to use it in a way that changes the tab size more than once, consider creating a version of the tool that is non-static.
