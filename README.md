# F# tutorial

![https://raw.githubusercontent.com/wiktornowicki/fsharp_doc/master/thumb.png](https://raw.githubusercontent.com/wiktornowicki/fsharp_doc/master/thumb.png)

Welcome to the F# tutorial created by me! While the language might seem to be difficult, once you get past the basics, you'll come to realise that it's not all that difficult. First of all, it's really similar to C# and Visual Basic .NET, so if you're familiar with either of these, F# won't be much of a challenge.

## Things you'll need
Of course, you'll need some things. It's recommended that you clean up your drive a bit, since you'll need to install the following things:

1. Visual Studio 201x (17/19 recommended)
2. The .NET Desktop Development component set
3. Select the following components in the **Individual components** section:
  * .NET Core 3.x SDK
  * .NET Framework 4.x targeting packs and SDKs
  * .NET profiling tools
  * F# desktop language support
  * F# language support
  * F# language support for web projects
  * IntelliCode
  * .NET Compiler Platform SDK.
 4. Once you're all done with this, the recommended project for creating programs is Console App (.NET Core).
 5. Now you're all set! Enjoy!

## Linux

.NET structures are designed mainly, but are not limited to, for Windows NT. You may be a Linux user, and you may want to compile your F# code on this OS, rather than dumping your drive with VMs. Luckilly for you, it is possible. Just do as follows:

1. Open the terminal.
2. Enter the following commands:

```
wget -q https://packages.microsoft.com/config/ubuntu/19.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get install dotnet-sdk-3.1
sudo apt-get install dotnet-runtime-3.1
```

Once you have these installed, just go to this [page](https://docs.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-command-line) for info regarding creating projects.
