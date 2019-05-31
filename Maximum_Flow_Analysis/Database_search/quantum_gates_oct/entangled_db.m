display("# Format of the database register:")
display("[ n1 | t1 t2 ]")
n1 = 1;       # 1 bit for the name
display("# 1 bit for the name")
n2 = 2;       # 2 bit for the telephone number
display("# 2 bit for the telephone number")
display("")

display("# all possible name values")
N1 = 2^n1
display("# all possible telephone number values")
N2 = 2^n2

display("# initialization hadamard matrix. Size: N1xN1")
init_H = H;
for i = 1:(n1-1)
  init_H = kron(init_H, H); # note that int this case order of kron parameters does not matter
endfor
H

display("# initialization of bottom primed matrix. Size: (N1*N2)x(N1*N2)")
bottom_primed_m = init_H;
for i = 1:n2
  bottom_primed_m = C(bottom_primed_m);
endfor
bottom_primed_m

display("# building the 8x8 primed matrix by exchanging the bottom-right 2x2 corner with the top-left 2x2 corner")
exchanger = kron(switch_g(1,4),eye(2));
# move the block vertically
primed_m = exchanger * bottom_primed_m;
# move the block horizontally
primed_m = primed_m * exchanger;
primed_m

display("# exchange rows")

# EXAMPLE
display("# we want to encode a database with the following values for name and telephone")
display(" __________________")
display("| value |name |tel |")
display("|_______|_____|____|")
display("|0-11(3)|  0  |  3 |")
display("|1-10(6)|  1  |  2 |")
display("|_______|_____|____|")
#{
  _________________
 | value |name |tel |
 |_______|_____|____|
 |0-11(3)|  0  |  3 |
 |1-10(6)|  1  |  2 |
 |_______|_____|____|
#}

m = primed_m;

display("# exchange rows 1 and 3")
m = SHIFT3 * m;
m = C(switch_g(1,3)) * m;
m = SHIFT3 * m;
m

display("# now exchange rows 2 and 6")
m = kron(switch_g(1,4),eye(2)) * m;
m = C(switch_g(2,4)) * m;
m = kron(switch_g(1,4),eye(2)) * m;
m

display("done")

# other examples
#{
# example: exchange rows 1 and 6
m = primed_m;
m = kron(switch_g(1,4),eye(2)) * m;
m = C(SWAP) * m;
m = kron(switch_g(1,4),eye(2)) * m;

# example: exchange rows 2 and 4
m = SHIFT3 * m;
m = C(switch_g(2,4)) * m;
m = SHIFT3 * m
#}