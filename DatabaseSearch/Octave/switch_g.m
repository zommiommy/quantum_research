function out = switch_g(row1, row2)
  
  if (row1>4) || (row1<1) || (row2>4) || (row2<1)
    display("Row parameters must be between 1 and 4");
    return;
  endif
  
  out = eye(4);
  
  if (row1 == row2)
    return;
  endif
  
  row_min = min(row1,row2);
  row_max = max(row1,row2);
  
  if (row_min == 1) && (row_max == 2)
    out = ICNOT;
  endif
  
  if (row_min == 1) && (row_max == 3)
    out = SWAP * ICNOT * SWAP;
  endif
  
  if (row_min == 1) && (row_max == 4)
    out = CNOT * SWAP * ICNOT * SWAP * CNOT;
  endif
  
  if (row_min == 2) && (row_max == 3)
    out = SWAP;
  endif
  
  if (row_min == 2) && (row_max == 4)
    out = CNOT * SWAP * CNOT;
  endif
  
  if (row_min == 3) && (row_max == 4)
    out = CNOT;
  endif
endfunction
