Kvant/SprayMV
=============

*SprayMV* is a specialized version of [*Spray*][KvantSpray] that supports motion
vector generation.

![gif](http://66.media.tumblr.com/16d17e7a51322c875719e2fe8a22f133/tumblr_od6tvwdMsW1qio469o1_320.gif)
![gif](http://67.media.tumblr.com/2c57cf6b66d54da6ce47ec5e8c74e23a/tumblr_od6tvwdMsW1qio469o2_320.gif)

![image](http://65.media.tumblr.com/ac1a4ea7e080a89fcce97cfd9c29ee9a/tumblr_od6t73uTlk1qio469o1_500.png)

The original version of *Spray* doesn't support motion vectors, and thus it
can't be used well with post-processing effects that requires motion vectors
(e.g. motion blur). *SprayMV* generates exact per-pixel motion vectors from
each individual particles. This allows depicting motion of a complex particle
system in a very natural way.

System Requirements
-------------------

- Unity 5.4 or later

Caution
-------

This is only a sort of quick and dirty hack -- implemented in a weird way for
some reasons. I made this "hack" because Graphics.DrawMesh doesn't support
motion vector generation (the original *Spray* is heavily dependent on it).
It should be redesigned when motion vector support is added to
Graphics.DrawMesh. Until then, this can be used as a workaround.

License
-------

Copyright (C) 2016 Keijiro Takahashi

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

[KvantSpray]: https://github.com/keijiro/KvantSpray
