#!/bin/bash
dotnet run
dot -Tpng outputGraph.dot -o image.png
dot -Tpng outputCompactGraph.dot -o imageCompact.png
xdg-open imageCompact.png 2>/dev/null
