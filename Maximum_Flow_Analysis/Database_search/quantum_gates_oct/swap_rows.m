function out_m = swap_rows(in_m, row1, row2)
  
  # BUBBLE SORT FASHION
  
  # matrix dimension
  N = rows(in_m);
  
  # input checks
  if (N < 4)
    display('Input matrix size not valid (must be at least 4x4).');
    return;
  endif
  if (N > 256)
    display('Input matrix too big (max is 256), stopped for performance reasons.');
    return;
  endif
  if (row1 <= 0) || (row1 > N)
    display('Row 1 value not valid');
    return;
  endif
  if (row2 <= 0) || (row2 > N)
    display('Row 2 value not valid');
    return;
  endif
  
  out_m = in_m;
  
  if (row1 == row2) # nothing to swap
    return;
  endif
  
  row_min = min(row1,row2);
  row_max = max(row1,row2);
  
  # rise up the bottom row
  for i = (row_max-1):-1:(row_min)
    out_m = swap_consecutive_rows(out_m, i);
  endfor
  
  # low down the top row
  for i = (row_min+1):(row_max-1)
    out_m = swap_consecutive_rows(out_m, i);
  endfor
  
endfunction

