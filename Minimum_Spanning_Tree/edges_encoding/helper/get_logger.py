

import logging

def get_logger(name : str) -> logging.Logger:
    logger = logging.getLogger(name) 

    if not logger.hasHandlers():
        logger.setLevel(logging.DEBUG)

        fh = logging.FileHandler('main.log')
        ch = logging.StreamHandler()

        formatter = logging.Formatter('[%(levelname)s - %(asctime)s - %(name)s]\t%(message)s')

        fh.setFormatter(formatter)
        ch.setFormatter(formatter)


        logger.addHandler(fh)
        logger.addHandler(ch)

    return logger
