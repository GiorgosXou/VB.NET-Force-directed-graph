# [VB.NET](https://en.wikipedia.org/wiki/Visual_Basic_.NET) Force directed graph 
with { +GPU, +DirectX, +GPU GUI Example of buttons}

A Simple but also quite powerful and Beautiful [Force directed graph](https://en.wikipedia.org/wiki/Force-directed_graph_drawing) made with Love for an upcoming project of mine and for everyone out there that needs some help over graph visualization in Visual Basic [...]
+<img src="/GraphVisual.gif">

# Features

- Uses [Cudafy.NET](https://en.wikipedia.org/wiki/CUDA)  for GPGPU calculation of forces.
- GUI like Interactions Using [DirectX](https://en.wikipedia.org/wiki/DirectX) for Drawing Stuffs.
- CPU Parallel algorithms for the rest of Graph interactions.
- OpenCL CudafyTranslator for plenty of GPU Cards support.
- Runs on ```NET Framework 4.0``` ! (✓ on Windows XP simulation).

# ```Important```

- ```Notes``` (at the Bottom of .md).
- Code is really not at all, optimized!
- Code will be "recreated" once i end with my other stuffs if not anyone❤︎ remake it until then.
- If you have Error Code.. S1023 when installing DirectX SDK, uninstall c++ 2010 redistributables.
- Check ["Remove integer overflow checks"](https://stackoverflow.com/questions/33742792/does-anyone-had-ever-successfully-utilized-cudafy-in-vb-net) under Project Properties > Compile > Advanced Compile Options > Optimizations. Else CUDAfy code wont Compile.
# Summary

|  | Papers - Manuals | Downloads |
| ------ | ------ | ------ |
|Visual Studio|-|[IDE](https://visualstudio.microsoft.com/)|
| CUDAfy Net| [Manual](http://www.nudoq.org/#!/Packages/CUDAfy.NET) , [2](https://manualzz.com/doc/6666114/cudafy.net-user-guide)|[Cudafy.NET](https://archive.codeplex.com/?p=cudafy)|
| DirectX |[Documentation](https://docs.microsoft.com/en-us/previous-versions/windows/desktop/bb318764(v%3dvs.85))|[SDK](https://www.microsoft.com/en-us/download/details.aspx?id=6812)|
| Gpaphs |[Simple Algorithm](https://pdfs.semanticscholar.org/9f0f/5a1507b83f96bcedbf2b8971fde21948b086.pdf)|-|


# Benchmark 
  ```Intel(R) HD Grapchics - Intel Core i7``` 
  * *```(Fast smooth Update)```*
* * 3000 [Nodes](https://www.google.gr/search?biw=1680&bih=944&ei=x7OLW9TqE9mpoASrv5foDQ&q=what+is+a+graph+node&oq=what+is+a+graph+node&gs_l=psy-ab.3...9531.11521.0.11725.10.9.0.0.0.0.483.887.4-2.2.0....0...1c.1.64.psy-ab..10.0.0....0.c9lrvm23Hqg)
* * 3576 [Edges](https://www.google.gr/search?biw=1680&bih=944&ei=OLaLW-mAHdLPwQKaubQI&q=what+is+a+graph+edges&oq=what+is+a+graph+edges&gs_l=psy-ab.3..0i22i30k1.5259.6377.0.6727.5.5.0.0.0.0.153.574.0j4.4.0....0...1c.1.64.psy-ab..1.4.568...0.0.d4EmwAC2ZZ0) (Connections)
* * 33 Millis/Frame
- *```(smooth Update)```*
* * 5000 Nodes 
* * 5935 Edges
* * 66 Millis/Frame
- *```(Slow Update)```*
* * 10.000 Nodes 
* * 11.921 edges (Connections)
* * 200 Millis/Frame

# Features I Wish For 
```Considering my knowledge at this moment [...]```
- Easy :
  -
  -- Thickness Of Lines, Based on Connections or etc.<br/>
  -- Size Of Node, Based on  Connections or etc.<br/>
  -- [...]<br/>

- Medium:
  -
  -- generally Low Level Grapchics<br/>
  -- Clustering algorithms<br/>
  -- Faster Algorithms<br/>

- Hard :
  -
  -- *3D Graph visualization*.<br/>
  -- *Make it as a Form **Control***. <br/>
  -- Recreation of most of the controls using DirectX.<br/>
  


# Searches Across Internet
---
| Intresting Papers 📝| Intresting Sites| Graphs|
| ------ | ------ | ------ |
|[Simple Algorithms for Network Visualization](https://pdfs.semanticscholar.org/9f0f/5a1507b83f96bcedbf2b8971fde21948b086.pdf)|[VB Graphics Programming: Part 4 (Optimizations Checklist)](http://www.tannerhelland.com/43/vb-graphics-programming-4/)|[graphing with Graphviz](http://www.washedashore.com/people/friendster/friendster3.html)|
|[A Force Directed Placement Method](https://pdfs.semanticscholar.org/0cb0/4409a72f4499a4a1bce0dffcf8e789ef8649.pdf)|[Direct3D For Dummiez (In VB6) written by: Matt Carpenter](http://agrino.org/hsg/DirectX/DX.htm)|[wingraphviz](http://wingraphviz.sourceforge.net/wingraphviz/)|
|[Force Directed Layout of Diagrams](https://pdfs.semanticscholar.org/0ad8/55e06fe6bba4fb265c74bfe44b54de7d3b0a.pdf)|[OpenCL Tutorial](http://www.cmsoft.com.br/opencl-tutorial/)|[quickgraph](https://archive.codeplex.com/?p=quickgraph)|
|[METHOD FOR FAST FORCE-DIRECTED LAYOUT OF LARGE SCALE-FREE NETWORK GRAPHS](https://dalspace.library.dal.ca/bitstream/handle/10222/65249/Lapierre-Nathan-MCSc-Dec-2015.pdf)|[General Purpose Computing on GPU in .NET World – Part 1](https://softwarehut.com/blog/general-purpose-computing-gpu-net-world-part-1/)|[3D force-directed graph written in C#](https://github.com/zongzhengli/force-directed)|
|[Efficient, High-Quality Force-Directed Graph Drawing](http://www.mathematica-journal.com/issue/v10i1/contents/graph_draw/graph_draw.pdf)|[General Purpose Computing on GPU in .NET World – Part 2](https://softwarehut.com/blog/general-purpose-computing-gpu-net-world-part-2/)|[HIVE PLOTS RATIONAL NETWORK VISUALIZATION](http://egweb.bcgsc.ca/)|
|[Visualizing solutions in network analysis with visual basic for applications](http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.466.7439&rep=rep1&type=pdf)|[A Visual and Interactive Guide to the Basics of Neural Networks]( http://jalammar.github.io/visual-interactive-guide-basics-neural-networks/)|[sciBASIC](https://github.com/xieguigang/sciBASIC)|
|[Exploiting GPUs for fast force-directed visualization of large-scale networks](http://liacs.leidenuniv.nl/~takesfw/pdf/exploiting-gpus-fast.pdf)|[Middle-square method](https://en.wikipedia.org/wiki/Middle-square_method)|
|[Improved Force-Directed Method of Graph Layout Generation with Adaptive Step Length](https://www.sciencedirect.com/science/article/pii/S1877050915034274)|[k-Means Clustering using CUDAfy.NET](https://antimatroid.wordpress.com/2015/09/01/k-means-clustering-using-cudafy-net/)|
|[Clustering and Community Detection in Directed Networks: A Survey](https://arxiv.org/pdf/1308.0971.pdf)|[When processor is not enough](https://www.future-processing.pl/blog/when-processor-is-not-enough/)|
|[Power Network Layout Generation using Force Directed Graph Technique](http://www.iitk.ac.in/npsc/Papers/NPSC2014/1569993659.pdf)|[<VBFixedString(3)>Dim i As String](https://www.codeproject.com/Answers/382294/How-can-i-declare-string-with-size.aspx#answer1)|
|[Barnes–Hut simulation](https://en.wikipedia.org/wiki/Barnes%E2%80%93Hut_simulation)|[Drawing with Direct3D, Part 1: Getting Started](http://www.devx.com/dotnet/Article/36102)|
|[campy GP-GPU computing](http://campynet.com/)|[OPENCL WRAPPERS](https://streamhpc.com/knowledge/for-developers/opencl-wrappers/)|

# ```Notes```

Please Dont blame me for my 🦆ed ☝️ 📄code :/ i had some difficult time, overcoming some things...so, i would say that, even if i had the whole summer quite free, i had not as much time,  as i would want to have in order to focus on this part of my project, way much more[...] +really wanted to upload it, before the end of summer holidays; thats why i am uploading it now, even if it is way to weirdly written. With hope that a "good samaritan" will find it intresting and fulfill my wishes.

With Love to all of you out there, George.

---
