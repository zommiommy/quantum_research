#!/bin/bash
echo "#########################################################"
echo "Stopping the istance if there is (This might take a few seconds)"
echo "#########################################################"
docker stop performance-test
docker rm performance-test

echo "#########################################################"
echo "Build the container"
echo "#########################################################"
docker build --file Dockerfile -t quantum-test-env .

echo "#########################################################"
echo "Run the container"
echo "#########################################################"
docker run -v $PWD/reports:/quantum/reports -it quantum-test-env 