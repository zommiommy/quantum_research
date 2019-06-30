#!/bin/bash
sudo docker build --file Dockerfile -t quantum-test-env
sudo docker run -d --name performance-test quantum-test-env
