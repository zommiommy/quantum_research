FROM ubuntu:18.04

# Install the basic utils we will need
RUN \
  apt-get update && \
  apt-get install -y wget && \
  rm -rf /var/lib/apt/lists/*

# Create a folder where we will work
RUN mkdir -p /quantum
RUN chmod 777 /quantum
WORKDIR /quantum

# Install python 3
RUN apt-get install -y python

# Install qiskit
RUN python3 -m pip install qiskit
RUN python3 -m pip install qiskit-aqua
RUN python3 -m pip install cirq

# Setup .NET for Q#
RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN add-apt-repository universe
RUN apt-get install apt-transport-https
RUN apt-get update
RUN apt-get install dotnet-sdk-2.2
# Install Q#
RUN dotnet tool install -g Microsoft.Quantum.IQSharp
# Update Q#
RUN dotnet tool update -g Microsoft.Quantum.IQSharp

# Synchronize the scripts between the folder and the docker
ADD scripts /quantum/scripts

# Add the test script
ADD test_all.sh /quantum
# add it as the entrypoint
ENTRYPOINT ["/test_all.sh"]
