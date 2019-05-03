from os import system

def execute(file_path : str) -> None:
    system("~/anaconda3/bin/python %s"%file_path)
    
# Clear the log
system("rm *.log")

execute("grover_test.py")
execute("graph_test.py")
execute("select_vertex.py")
execute("select_multiple_vertex.py")