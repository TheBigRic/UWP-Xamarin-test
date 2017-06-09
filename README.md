# Reproduction of Frame issue

While playing around with UWP, Xamarin Forms and Caliburn Micro I came across a weird and hard to debug exception. 

I traced it down to the following:
- xamarin Forms UWP
- CommandBar with a single AppBarButton without an icon set (this is coming from the master-detail template in VS2017)
- Set the `Window.Current.Content` to a `Page` instead of a `Frame` (coming from the setup guide of Caliburn Micro for xamarin forms with UWP)

The exception can be solved in 2 ways:
- Set a valid icon for the `AppBarButton`
- Set the rootelement to a `Frame`

App1
===============

- A stripped Xamarin Forms master-detail template app, with only a UWP project and the PCL
- When the App starts, a popup will show what to use as rootelement - a `Frame` or a `Page`
- With the `Frame`, it runs as expected
- With the `Page`, it hits an exception (without stacktrace!!)

App2
===============

- A blank UWP app without Xamarin Forms
- Rootelement set to `Page`
- `CommandBar` with iconless `AppBarButton`

Runs without exceptions