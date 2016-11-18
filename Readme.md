
## SpiderTrap

* An ASP.NET implementation of [SpiderTrap](https://github.com/adhdproject/adhdproject.github.io/blob/master/Tools/Spidertrap.md).
* If `<a href="/Spider"></a> ` is on any accessible page, the web crawler will get stuck in an endless loop.
* Use `wget -m http://127.0.0.1:5000 -nH` to test.
* If the SpiderTrap is active, the above line will never finish.
  
