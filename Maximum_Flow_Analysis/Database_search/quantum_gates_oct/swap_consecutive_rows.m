function out_m = swap_consecutive_rows(in_m, row_num)
  
  # matrix dimension
  N = rows(in_m);
  # qubits number
  n = log2(N);
  
  # number of qubits must be an integer greater than 1
  if (n < 2)
    display('Number of qubits not valid');
    return;
  endif
  
  # for performance reasons we forbid a number of qubits greater than 8
  if (n > 8)
    display('Too many qubits, stopped for performance reasons');
    return;
  endif
  
  # row_num must be an integer greater than 0 and smaller than N
  if (row_num <= 0) || (row_num >= N)
    display('Row number not valid');
    return;
  endif
  
  if (is_even(row_num))
    # when even
    pre = eye(row_num-2);
    post = eye(N-(row_num+2));
    S = blkdiag(pre, SWAP, post);
    display("applying:")
    S
    printf("swap controlled by %d qubits\n", n-2);
  else
    # when odd
    pre = eye(row_num-1);
    post = eye(N - (row_num+1));
    S = blkdiag(pre, X, post);
  endif
  
  out_m = S * in_m;
endfunction

function p = is_even(number)
  if (mod(number, 2) == 0)
    p = true;
  else
    p = false;
  endif
  return;
endfunction
