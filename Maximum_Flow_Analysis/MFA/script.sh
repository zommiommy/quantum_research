#!/bin/bash
dotnet run
dot -Tpng outputGraph.dot -o image.png
xdg-open image.png 2>/dev/null
