function out = C(in)
  size = rows(in);
  out = blkdiag(eye(size),in);
endfunction
