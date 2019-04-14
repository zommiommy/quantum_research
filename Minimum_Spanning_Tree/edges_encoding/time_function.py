

from time import time

from get_logger import get_logger

def time_function(func):

    logger = get_logger(func.__name__) 

    def wrapped(*args, **kwargs):
        start = time()

        result = func(*args,**kwargs)

        end = time()
        logger.info("The function {} took {} seconds.".format(func.__name__, end - start))

        return result
    return wrapped