#!/bin/bash
dotnet run
echo "Generating large graph image..."
dot -Tpng ./DotFiles/outputGraph.dot -o ./Images/image.png
echo "Done."
echo "Generating compact graph image..."
dot -Tpng ./DotFiles/outputCompactGraph.dot -o ./Images/imageCompact.png
echo "Done."
echo "Opening compact graph image..."
xdg-open ./Images/imageCompact.png 2>/dev/null
echo "Done."
