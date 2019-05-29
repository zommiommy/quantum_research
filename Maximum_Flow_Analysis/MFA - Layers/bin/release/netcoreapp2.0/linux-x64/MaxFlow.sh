#!/bin/bash
./MFA\ \ -\ Layers
dot -Tpng outputGraph.dot -o image.png
dot -Tpng outputCompactGraph.dot -o imageCompact.png
xdg-open imageCompact.png 2>/dev/null
