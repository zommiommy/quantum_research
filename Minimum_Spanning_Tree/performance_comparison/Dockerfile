FROM ubuntu:18.04
# Install the basic utils we will need
RUN apt-get update && \
  apt-get install -y gcc time vim wget bash neofetch software-properties-common && \
  apt-get upgrade -y 
# Create a folder where we will work
RUN mkdir -p /quantum && chmod 777 /quantum
WORKDIR /quantum

# Make the instance killabel with Ctrl-C
STOPSIGNAL 15

# Setup .NET for Q#
RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb \
  -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb && rm packages-microsoft-prod.deb
RUN add-apt-repository universe
RUN apt-get install -y apt-transport-https
RUN apt-get update
RUN apt-get install -y dotnet-sdk-2.2
# Install Q#
RUN dotnet tool install -g Microsoft.Quantum.IQSharp
# Update Q#
RUN dotnet tool update -g Microsoft.Quantum.IQSharp

# Install python3 with miniconda
RUN wget -q https://repo.anaconda.com/miniconda/Miniconda3-latest-Linux-x86_64.sh -O miniconda.sh 
RUN mkdir -p /root
RUN bash miniconda.sh -b
RUN rm miniconda.sh

# Add the executables to path
RUN ln -s /root/miniconda3/bin/python3 /bin/python3
RUN ln -s /root/miniconda3/bin/python3 /bin/python
RUN ln -s /root/miniconda3/bin/pip /bin/pip

# Install the library needed by cirq
RUN apt-get install -y libx11-6
# Install cirq
RUN python -m pip install cirq

# Install qiskit & qiskit-aqua
RUN python -m pip install qiskit qiskit_aqua

# Synchronize the scripts between the folder and the docker
ADD scripts /quantum/scripts

# Add the test script
ADD grid_test.sh /quantum
ADD test_all.sh /quantum

# Clear the apt-get cache
RUN rm -rf /var/lib/apt/lists/*Page 