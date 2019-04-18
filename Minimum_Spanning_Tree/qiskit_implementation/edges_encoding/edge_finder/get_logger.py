

import logging

def get_logger(name : str) -> logging.Logger:
    logger = logging.getLogger(name) 

    if not logger.hasHandlers():
        logger.setLevel(logging.DEBUG)

        fh = logging.FileHandler('log.log')
        ch = logging.StreamHandler()

        file_formatter   = logging.Formatter('[%(levelname)s - %(asctime)s - %(name)s]\t%(message)s')
        stream_formatter = logging.Formatter('[%(levelname)s-%(name)s] %(message)s')

        fh.setFormatter(file_formatter)
        ch.setFormatter(stream_formatter)


        logger.addHandler(fh)
        logger.addHandler(ch)

    return logger
