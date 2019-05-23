function out = swap_rows_quantum(in, row1, row2, nondestructive)
  
  if (rows(in) != 4) || (columns(in) != 4)
    display("Matrix is not 4x4");
    return;
  endif
  
  if (row1>4) || (row1<1) || (row2>4) || (row2<1)
    display("Row parameters must be between 1 and 4");
    return;
  endif
  
  if (row1 == row2)
    out = in;
    return;
  endif
  
  row_min = min(row1,row2);
  row_max = max(row1,row2);
  
  if (row_min == 1) && (row_max == 2)
    out = in * ICNOT;
  endif
  
  if (row_min == 1) && (row_max == 3)
    out = in * SWAP * ICNOT;
    if nondestructive
      out = out * SWAP;
    endif
  endif
  
  if (row_min == 1) && (row_max == 4)
    out = in * CNOT * SWAP * ICNOT;
    if nondestructive
      out = out * SWAP * CNOT;
    endif
  endif
  
  if (row_min == 2) && (row_max == 3)
    out = in * SWAP;
  endif
  
  if (row_min == 2) && (row_max == 4)
    out = in * CNOT * SWAP;
    if nondestructive
      out = out * CNOT;
    endif
  endif
  
  if (row_min == 3) && (row_max == 4)
    out = in * CNOT;
  endif
  
endfunction
